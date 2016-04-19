


















// Generated on 06/04/2015 18:45:35
using System;
using System.Collections.Generic;
using System.Linq;
using Symbioz.Utils;

namespace Symbioz.DofusProtocol.Types
{

public class SkillActionDescriptionCraft : SkillActionDescription
{

public const short Id = 100;
public override short TypeId
{
    get { return Id; }
}

public sbyte probability;
        

public SkillActionDescriptionCraft()
{
}

public SkillActionDescriptionCraft(ushort skillId, sbyte probability)
         : base(skillId)
        {
            this.probability = probability;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

base.Serialize(writer);
            writer.WriteSByte(probability);
            

}

public override void Deserialize(ICustomDataInput reader)
{

base.Deserialize(reader);
            probability = reader.ReadSByte();
            if (probability < 0)
                throw new Exception("Forbidden value on probability = " + probability + ", it doesn't respect the following condition : probability < 0");
            

}


}


}