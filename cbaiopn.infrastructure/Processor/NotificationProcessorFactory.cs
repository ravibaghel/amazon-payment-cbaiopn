using System;
using cbaiopn.core;

namespace cbaiopn.infrastructure.processor
{
	public class NotificationProcessorFactory
	{
		public static INotificationProcessor GetProcessor(NotificationType type)
		{
			INotificationProcessor notificationProcessor = null;
			// Based on the NotificationType, instantiate the appropriate the
			// notificationProcessor
			switch (type)
			{
			case NotificationType.NewOrderNotification:
				notificationProcessor = new NewOrderNotificationProcessor();
				break;

			case NotificationType.OrderReadyToShipNotification:
				notificationProcessor = new OrderReadyToShipNotificationProcessor();
				break;

			case NotificationType.OrderCancelledNotification:
				notificationProcessor = new OrderCancelledNotificationProcessor();
				break;
			}

			return notificationProcessor;

		}
	}
}

