using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

/**
 * A simple class that demostrates how to generate a signature with the
 * user specified paramters: Merchant ID, AWS Access Key ID and AWS Secret Key
 * ID
 * 
 * Copyright 2008-2008 Amazon.com, Inc., or its affiliates. All Rights Reserved. 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 * 		http://aws.amazon.com/apache2.0/
 * 
 * or in the "license" file accompanying this file.
 * This file is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language
 * governing permissions and limitations under the License.
 */

namespace cbaiopn.core.common
{
    public class SignatureCalculator
    {
        public SignatureCalculator()
        {
        }

		public static String computeSignature(string uuid, string timestamp,
			string awsSecretKey){
			string data = uuid + timestamp;
			return calculateRFC2104HMAC (data, awsSecretKey);
		}


        public static String calculateRFC2104HMAC(String data, String key)
        {
            String result = null;
            
            HMACSHA1 mac = new HMACSHA1(ASCIIEncoding.UTF8.GetBytes(key));

            byte[] hashed = mac.ComputeHash(ASCIIEncoding.UTF8.GetBytes(data));

            result = System.Convert.ToBase64String(hashed);

            return result;
        }
    }
}
