


















// Generated on 06/04/2015 18:44:41
using System;
using System.Collections.Generic;
using System.Linq;
using Symbioz.DofusProtocol.Types;
using Symbioz.Utils;

namespace Symbioz.DofusProtocol.Messages
{

public class GameRolePlaySpellAnimMessage : Message
{

public const ushort Id = 6114;
public override ushort MessageId
{
    get { return Id; }
}

public int casterId;
        public ushort targetCellId;
        public ushort spellId;
        public sbyte spellLevel;
        

public GameRolePlaySpellAnimMessage()
{
}

public GameRolePlaySpellAnimMessage(int casterId, ushort targetCellId, ushort spellId, sbyte spellLevel)
        {
            this.casterId = casterId;
            this.targetCellId = targetCellId;
            this.spellId = spellId;
            this.spellLevel = spellLevel;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteInt(casterId);
            writer.WriteVarUhShort(targetCellId);
            writer.WriteVarUhShort(spellId);
            writer.WriteSByte(spellLevel);
            

}

public override void Deserialize(ICustomDataInput reader)
{

casterId = reader.ReadInt();
            targetCellId = reader.ReadVarUhShort();
            if ((targetCellId < 0) || (targetCellId > 559))
                throw new Exception("Forbidden value on targetCellId = " + targetCellId + ", it doesn't respect the following condition : (targetCellId < 0) || (targetCellId > 559)");
            spellId = reader.ReadVarUhShort();
            if (spellId < 0)
                throw new Exception("Forbidden value on spellId = " + spellId + ", it doesn't respect the following condition : spellId < 0");
            spellLevel = reader.ReadSByte();
            if ((spellLevel < 1) || (spellLevel > 6))
                throw new Exception("Forbidden value on spellLevel = " + spellLevel + ", it doesn't respect the following condition : (spellLevel < 1) || (spellLevel > 6)");
            

}


}


}