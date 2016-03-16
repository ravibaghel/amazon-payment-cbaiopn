using System;

/**
 * Exception class used for indicating errors while processing the notification
 */
namespace cbaiopn.core.Exceptions
{
	public class CBAIOPNException:Exception
	{
		public CBAIOPNException ():base()
		{
			
		}

		public CBAIOPNException (String message):base(message)
		{

		}
		public CBAIOPNException (String message, Exception inner):base(message,inner)
		{

		}
	}
}

