


















// Generated on 06/04/2015 18:44:25
using System;
using System.Collections.Generic;
using System.Linq;
using Symbioz.DofusProtocol.Types;
using Symbioz.Utils;

namespace Symbioz.DofusProtocol.Messages
{

public class MapRunningFightDetailsRequestMessage : Message
{

public const ushort Id = 5750;
public override ushort MessageId
{
    get { return Id; }
}

public int fightId;
        

public MapRunningFightDetailsRequestMessage()
{
}

public MapRunningFightDetailsRequestMessage(int fightId)
        {
            this.fightId = fightId;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteInt(fightId);
            

}

public override void Deserialize(ICustomDataInput reader)
{

fightId = reader.ReadInt();
            if (fightId < 0)
                throw new Exception("Forbidden value on fightId = " + fightId + ", it doesn't respect the following condition : fightId < 0");
            

}


}


}