using System;

namespace cbaiopn.core.Exceptions
{
	public class CBAIOPNClientException:CBAIOPNException
	{
		public CBAIOPNClientException ():base()
		{

		}

		public CBAIOPNClientException (String message):base(message)
		{

		}
		public CBAIOPNClientException (String message, Exception inner):base(message,inner)
		{

		}
	}
}

