﻿using fac.ASTs.Exprs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fac.ASTs.Stmts {
	class AstStmt_DefVariable: IAstStmt {
		public string DataType { get; set; } = "";
		public string VarName { get; set; }
		public IAstExpr Expr { get; set; }



		public override void Traversal (int _deep, int _group, Func<IAstExpr, int, int, IAstExpr> _cb) {
			Expr = _cb (Expr, _deep, _group);
		}
	}
}
