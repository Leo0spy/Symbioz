


















// Generated on 06/04/2015 18:45:18
using System;
using System.Collections.Generic;
using System.Linq;
using Symbioz.Utils;

namespace Symbioz.DofusProtocol.Types
{

public class StatisticDataBoolean : StatisticData
{

public const short Id = 482;
public override short TypeId
{
    get { return Id; }
}

public bool value;
        

public StatisticDataBoolean()
{
}

public StatisticDataBoolean(ushort actionId, bool value)
         : base(actionId)
        {
            this.value = value;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

base.Serialize(writer);
            writer.WriteBoolean(value);
            

}

public override void Deserialize(ICustomDataInput reader)
{

base.Deserialize(reader);
            value = reader.ReadBoolean();
            

}


}


}