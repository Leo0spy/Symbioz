


















// Generated on 06/04/2015 18:44:27
using System;
using System.Collections.Generic;
using System.Linq;
using Symbioz.DofusProtocol.Types;
using Symbioz.Utils;

namespace Symbioz.DofusProtocol.Messages
{

public class EmotePlayErrorMessage : Message
{

public const ushort Id = 5688;
public override ushort MessageId
{
    get { return Id; }
}

public byte emoteId;
        

public EmotePlayErrorMessage()
{
}

public EmotePlayErrorMessage(byte emoteId)
        {
            this.emoteId = emoteId;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteByte(emoteId);
            

}

public override void Deserialize(ICustomDataInput reader)
{

emoteId = reader.ReadByte();
            if ((emoteId < 0) || (emoteId > 255))
                throw new Exception("Forbidden value on emoteId = " + emoteId + ", it doesn't respect the following condition : (emoteId < 0) || (emoteId > 255)");
            

}


}


}