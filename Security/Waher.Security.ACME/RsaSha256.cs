﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace Waher.Security.ACME
{
	/// <summary>
	/// RSA with SHA-256 signatures
	/// </summary>
	public class RsaSha256 : Rsa
	{
		/// <summary>
		/// RSA with SHA-256 signatures
		/// </summary>
		/// <param name="RSA">RSA cryptogaphic service provider.</param>
		public RsaSha256(RSACryptoServiceProvider RSA)
			: base(RSA)
		{
		}

		/// <summary>
		/// Object Identity for the Hash algorithm.
		/// </summary>
		public override string HashAlgorithmOID => "1.2.840.113549.1.1.11";

		/// <summary>
		/// Name of hash algorithm to use for signatues.
		/// </summary>
		public override HashAlgorithmName HashAlgorithmName => HashAlgorithmName.SHA256;

	}
}
