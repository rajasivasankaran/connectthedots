﻿namespace Microsoft.ConnectTheDots.Gateway
{
    using System;

    //--//

    public interface IDeviceAdapter
    {
        bool Start( Func<string, int> enqueue );

        bool Stop( );

        //leave endpoint null for Data Intakes that don't expect any endpoints
        bool SetEndpoint( SensorEndpoint endpoint = null );
    }
}
