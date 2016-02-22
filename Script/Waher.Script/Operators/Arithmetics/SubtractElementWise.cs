﻿using System;
using System.Collections.Generic;
using System.Text;
using Waher.Script.Abstraction.Elements;
using Waher.Script.Abstraction.Sets;
using Waher.Script.Exceptions;
using Waher.Script.Model;
using Waher.Script.Objects;

namespace Waher.Script.Operators.Arithmetics
{
	/// <summary>
	/// Element-wise Subtraction operator.
	/// </summary>
	public class SubtractElementWise : BinaryScalarOperator 
	{
		/// <summary>
		/// Element-wise Subtraction operator.
		/// </summary>
		/// <param name="Left">Left operand.</param>
		/// <param name="Right">Right operand.</param>
		/// <param name="Start">Start position in script expression.</param>
		/// <param name="Length">Length of expression covered by node.</param>
		public SubtractElementWise(ScriptNode Left, ScriptNode Right, int Start, int Length)
			: base(Left, Right, Start, Length)
		{
		}

        /// <summary>
        /// Evaluates the operator on scalar operands.
        /// </summary>
        /// <param name="Left">Left value.</param>
        /// <param name="Right">Right value.</param>
        /// <param name="Variables">Variables collection.</param>
        /// <returns>Result</returns>
        public override IElement EvaluateScalar(IElement Left, IElement Right, Variables Variables)
		{
			DoubleNumber DL = Left as DoubleNumber;
			DoubleNumber DR = Right as DoubleNumber;

			if (DL != null && DR != null)
				return new DoubleNumber(DL.Value - DR.Value);
			else
				return Subtract.EvaluateSubtraction(Left, Right, this);
		}

	}
}
