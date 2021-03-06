/*
 *                         OpenSplice DDS
 *
 *   This software and documentation are Copyright 2006 to TO_YEAR PrismTech
 *   Limited, its affiliated companies and licensors. All rights reserved.
 *
 *   Licensed under the Apache License, Version 2.0 (the "License");
 *   you may not use this file except in compliance with the License.
 *   You may obtain a copy of the License at
 *
 *       http://www.apache.org/licenses/LICENSE-2.0
 *
 *   Unless required by applicable law or agreed to in writing, software
 *   distributed under the License is distributed on an "AS IS" BASIS,
 *   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *   See the License for the specific language governing permissions and
 *   limitations under the License.
 */

using System;
using System.Runtime.InteropServices;
using DDS.OpenSplice.CustomMarshalers;

namespace DDS.OpenSplice.Common
{

    [StructLayout(LayoutKind.Sequential)]
    public class EntityStatus
    {
       public uint State;
    }

    [StructLayout(LayoutKind.Sequential)]
    public class TopicStatus : EntityStatus
    {
       public DDS.InconsistentTopicStatus InconsistentTopic;
    }

    [StructLayout(LayoutKind.Sequential)]
    public class WriterStatus : EntityStatus
    {
       public DDS.LivelinessLostStatus          LivelinessLost;
       public DDS.OfferedDeadlineMissedStatus   DeadlineMissed;
       public DDS.OfferedIncompatibleQosStatus  IncompatibleQos;
       public DDS.PublicationMatchedStatus      PublicationMatch;
    }

    [StructLayout(LayoutKind.Sequential)]
    public class ReaderStatus : EntityStatus
    {
       public DDS.LivelinessChangedStatus        LivelinessChanged;
       public DDS.SampleRejectedStatus           SampleRejected;
       public DDS.SampleLostStatus               SampleLost;
       public DDS.RequestedDeadlineMissedStatus  DeadlineMissed;
       public DDS.RequestedIncompatibleQosStatus IncompatibleQos;
       public DDS.SubscriptionMatchedStatus      SubscriptionMatch;
    }
}
