using System;
/**
 * Exception class used for indicating any errors while processing the notification,
 * which occurs because of wrong configuration, wrong settings or missing resources
 * at the merchant side endpoint. Merchant side being the server for IOPN requests,
 * this exception is used to indicate any errors at the server side.
 */
namespace cbaiopn.core.Exceptions
{
	public class CBAIOPNServerException:CBAIOPNException
	{
		public CBAIOPNServerException ():base()
		{

		}

		public CBAIOPNServerException (String message):base(message)
		{

		}
		public CBAIOPNServerException (String message, Exception inner):base(message,inner)
		{

		}
	}
}

