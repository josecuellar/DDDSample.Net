﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DDDSampleNET.Domain.Cargo;

namespace DDDSampleNET.Application
{
   /// <summary>
   /// Cargo inspection service.
   /// </summary>
   public interface CargoInspectionService
   {
      /// <summary>
      /// Inspect cargo and send relevant notifications to interested parties,
      /// for example if a cargo has been misdirected, or unloaded
      /// at the final destination.
      /// </summary>
      /// <param name="trackingId">Cargo tracking id.</param>   
      void InspectCargo(TrackingId trackingId);
   }
}
