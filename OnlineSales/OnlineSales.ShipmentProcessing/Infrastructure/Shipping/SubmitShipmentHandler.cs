﻿//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by ServiceMatrix.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using NServiceBus;
using OnlineSales.Internal.Commands.Shipping;


namespace OnlineSales.Shipping
{
    public partial class SubmitShipmentHandler : IHandleMessages<SubmitShipment>
    {
		
		public void Handle(SubmitShipment message)
		{
			// Handle message on partial class
			this.HandleImplementation(message);
		}

		partial void HandleImplementation(SubmitShipment message);

        public IBus Bus { get; set; }

    }

	
}