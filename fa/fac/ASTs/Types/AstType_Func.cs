﻿using Antlr4.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fac.ASTs.Types {
	public class AstType_Func: IAstType {
		public IAstType ReturnType { get; set; }
		public List<IAstType> ArgumentTypes { get; set; }



		public override string ToString () {
			var _list = new List<IAstType> ();
			_list.AddRange (ArgumentTypes);
			_list.Add (ReturnType);
			return $"Func<{string.Join (", ", _list)}>";
		}
		//public static AstType_Func FromType (string _type_str, IToken _token, List<IAstType> _templates) {
		//	if (_type_str != "Func" && _type_str != "Action")
		//		return null;
		//	var _functype = new AstType_Func { Token = _token };
		//	if (_type_str == "Func") {
		//		_functype.ReturnType = _templates[^1];
		//		_templates.RemoveAt (_templates.Count - 1);
		//		_functype.ArgumentTypes = _templates;
		//	} else {
		//		_functype.ReturnType = new AstType_Void { Token = _token };
		//	}
		//	return _functype;
		//}

		public override string GenerateCSharp (int _indent) {
			if (ReturnType is AstType_Void) {
				return $"Action<{string.Join (", ", from p in ArgumentTypes select p.GenerateCSharp (_indent))}>";
			} else {
				var _list = new List<IAstType> ();
				_list.AddRange (ArgumentTypes);
				_list.Add (ReturnType);
				return $"Func<{string.Join (", ", from p in _list select p.GenerateCSharp (_indent))}>";
			}
		}
	}
}
