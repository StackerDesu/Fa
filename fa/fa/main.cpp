﻿//#define _SILENCE_CXX17_CODECVT_HEADER_DEPRECATION_WARNING
//#define _SILENCE_ALL_CXX17_DEPRECATION_WARNINGS
//#define _CRT_SECURE_NO_WARNINGS
//#define ANTLR4CPP_STATIC
#pragma warning (disable: 4141)
#pragma warning (disable: 4146)
#pragma warning (disable: 4244)
#pragma warning (disable: 4624)



#include <algorithm>
#include <conio.h>
#include <filesystem>
#include <fstream>
#include <iostream>
#include <sstream>
#include <string>
#include <vector>

#include "AstExprOrValue.h"
#include "FaParser.h"
#include "FaLexer.h"
#include "CodeVisitor.hpp"
#include "FaLLVMGen.hpp"
#include "Log.hpp"

//#pragma comment (lib, "antlr4-runtime.lib")



std::string _read_file (std::string _file) {
	std::ifstream ifs (_file, std::ios::binary);
	//m_bytes = std::string ((std::istreambuf_iterator<char> (ifs)), std::istreambuf_iterator<char> ()); // low performance
	ifs.seekg (0, std::ios::end);
	size_t _fsz = (size_t) ifs.tellg ();
	ifs.seekg (0, std::ios::beg);
	std::string _data;
	_data.resize (_fsz);
	ifs.read (&_data [0], (std::streamsize) _fsz);
	ifs.close ();
	return _data;
}

std::string _link (std::string _dest, std::vector<std::string> &_libs) {
	wchar_t* get_env (std::string _key, std::string _val);
	bool check_file_exist (std::string _file);
	std::string _link_exe_path = R"(D:\Software\Editor\vs2019\Community\VC\Tools\MSVC\14.29.30133\bin\Hostx86\x86\link.exe)";
	wchar_t* _env;
	if (check_file_exist (_link_exe_path)) {
		// home
		//_link_exe_path = 
		_env = get_env ("LIB", R"(D:\Software\Editor\vs2019\Community\VC\Tools\MSVC\14.29.30133\ATLMFC\lib\x86;D:\Software\Editor\vs2019\Community\VC\Tools\MSVC\14.29.30133\lib\x86;C:\Program Files (x86)\Windows Kits\NETFXSDK\4.8\lib\um\x86;D:\Windows Kits\10\lib\10.0.19041.0\ucrt\x86;D:\Windows Kits\10\lib\10.0.19041.0\um\x86)");
	} else {
		// company
		_link_exe_path = R"(E:\Software\Microsoft Visual Studio\2019\Community\VC\Tools\MSVC\14.29.30037\bin\Hostx86\x86\link.exe)";
		_env = get_env ("LIB", R"(E:\Software\Microsoft Visual Studio\2019\Community\VC\Tools\MSVC\14.29.30037\ATLMFC\lib\x86;E:\Software\Microsoft Visual Studio\2019\Community\VC\Tools\MSVC\14.29.30037\lib\x86;C:\Program Files (x86)\Windows Kits\NETFXSDK\4.8\lib\um\x86;D:\Windows Kits\10\lib\10.0.19041.0\ucrt\x86;D:\Windows Kits\10\lib\10.0.19041.0\um\x86)");
	}
	std::string _cmd = std::format ("\"{}\" /subsystem:console /dynamicbase /machine:X86 /debug /entry:@fa_main /out:{}.exe /pdb:{}.pdb", _link_exe_path, _dest, _dest);
	// 依赖处理差的链接命令
	// link /subsystem:console /dynamicbase /machine:X86 /debug /entry:@fa_main /out:hello.exe /pdb:hello.pdb hello.obj "libucrt.lib" "libcmt.lib"
	// 编译程序无法运行的链接命令
	// link /OUT:"hello.exe" /MANIFEST /LTCG:incremental /NXCOMPAT /PDB:"hello.pdb" /DYNAMICBASE /entry:@fa_main hello.obj "libucrt.lib" "libcmt.lib" /DEBUG /MACHINE:X86 /OPT:REF /SAFESEH /INCREMENTAL:NO /SUBSYSTEM:CONSOLE /MANIFESTUAC:"level='asInvoker' uiAccess='false'" /ManifestFile:"hello.exe.intermediate.manifest" /LTCGOUT:"hello.iobj" /OPT:ICF /ERRORREPORT:PROMPT /ILK:"hello.ilk" /NOLOGO /TLBID:1
	for (auto _lib : _libs) {
		_cmd += " ";
		_cmd += _lib;
	}
	std::string get_process_output (std::string _cmd, wchar_t* _env);
	return get_process_output (_cmd, _env);
}

int main (int argc, char* argv[]) {
	//auto test = +*??(:>()<%??>;
	std::filesystem::current_path ("D:\\fa_tmp");
	//
	std::vector<std::string>							_libs;				// 全局链接库
	std::map<std::string, std::shared_ptr<FuncType>>	_global_funcs;		// 全局函数
	AstClasses											_global_classes {};	// 全局类
	//
	std::vector<std::string> enum_files (std::string _path);
	std::string _project_name = "hello";
	std::vector<std::shared_ptr<FaLLVMGen>> _gens;
	std::string _src_path = R"(E:\GitHub\_\fa\src)";
	auto _files = enum_files (_src_path);
	if (_files.size () == 0) {
		_src_path = R"(D:\GitHub\_\fa\src)";
		_files = enum_files (_src_path);
	}
	std::cout << "----------开始解析项目结构----------" << std::endl;
	for (std::string _file : _files) {
		// 源码文件路径
		std::string _full_path = std::format ("{}\\{}", _src_path, _file);

		// 源码
		std::string _source = _read_file (_full_path);

		// 命名空间
		size_t _p = _file.rfind ('\\');
		std::string _child_namespace = _file.substr (0, _p);
		std::replace_if (_child_namespace.begin (), _child_namespace.end (), [] (char ch) { return ch == '\\'; }, '.');
		std::string _namespace = (_p == std::string::npos ? _project_name : std::format ("{}.{}", _project_name, _child_namespace));

		// 模块名称
		std::string _module_name = std::format ("{}.{}", _namespace, _file.substr (_p + 1));
		_p = _module_name.rfind ('.');
		_module_name = _module_name.substr (0, _p);

		// 开始编译
		auto _stream = std::make_shared<antlr4::ANTLRInputStream> (_source);
		auto _lexer = std::make_shared<FaLexer> (_stream.get ());
		auto _cts = std::make_shared<antlr4::CommonTokenStream> (_lexer.get ());
		_cts->fill ();
		auto _gen = std::make_shared<FaLLVMGen> (_module_name, _namespace, _libs, _global_funcs, _global_classes);
		Log::SetCurrentFile (_file, _source);
		if (!_gen->InitClassVar (_file, _source, _stream, _lexer, _cts)) {
			std::cout << "compile failed." << std::endl;
			std::cout << "press any key to exit." << std::endl;
			::_getch ();
			exit (0);
			return 0;
		}
		_gens.push_back (_gen);
	}
	for (auto _gen : _gens) {
		bool _success = _gen->InitClassFunc ();
		if (!_success) {
			std::cout << "compile failed." << std::endl;
			std::cout << "press any key to exit." << std::endl;
			::_getch ();
			exit (0);
			return 0;
		}
	}
	for (auto _gen : _gens) {
		std::cout << std::format ("----------正在编译 {}----------", _gen->m_file) << std::endl;
		Log::SetCurrentFile (_gen->m_file, _gen->m_source);
		bool _success = _gen->Compile ();
		if (!_success) {
			std::cout << "compile failed." << std::endl;
			std::cout << "press any key to exit." << std::endl;
			::_getch ();
			exit (0);
			return 0;
		}
	}
	//
	//// link /out:hello.exe /subsystem:console /entry:fa_entry_main hello.obj
	////std::string _out = _gen.Link (R"(E:\Software\Microsoft Visual Studio\2019\Community\VC\Tools\MSVC\14.28.29910\bin\Hostx86\x86\link.exe)");
	std::string _out = _link (_project_name, _libs);
	std::cout << _out << std::endl;

	std::cout << "press any key to exit." << std::endl;
	::_getch ();
	exit (0);
	return 0;
}
