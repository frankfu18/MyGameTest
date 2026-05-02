using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.sysbuff
{
[System.Serializable]
public  class CastleAddAtkSlotSysBuff : SysBuffInfo
 {




    public const int TYPE_ID = 16486;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public CastleAddAtkSlotSysBuff(Perfect.Marshal.Octets os) : base(os)  {

    }

    public CastleAddAtkSlotSysBuff()
    {
    }

    public CastleAddAtkSlotSysBuff(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "CastleAddAtkSlotSysBuff");
    }


}
}
}
