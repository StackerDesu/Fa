﻿using fac.Structures;
using System.Collections.Generic;

namespace fac {
	class Info {
		/// <summary>
		/// 项目名
		/// </summary>
		public static string ProjectName = "";

		/// <summary>
		/// 项目源码路径
		/// </summary>
		public static string Path = "";

		/// <summary>
		/// 项目引用的外部库
		/// </summary>
		public static HashSet<string> ExternLibs = new HashSet<string> ();



		/// <summary>
		/// 当前源码文件
		/// </summary>
		public static string CurrentFile = "";

		/// <summary>
		/// 当前源码
		/// </summary>
		public static string CurrentCode = "";

		/// <summary>
		/// 当前相对路径
		/// </summary>
		public static string CurrentRelativeFile {
			get {
				string _s = CurrentFile.Substring (Path.Length);
				if (_s[0] == '/' || _s[0] == '\\')
					_s = _s.Substring (1);
				return _s;
			}
		}

		/// <summary>
		/// 当前命名空间
		/// </summary>
		public static string CurrentNamespace = "";

		/// <summary>
		/// 当前命名空间引用
		/// </summary>
		public static List<string> CurrentUses;

		public static List<ExternApi> CurrentExternApis;
	}
}
