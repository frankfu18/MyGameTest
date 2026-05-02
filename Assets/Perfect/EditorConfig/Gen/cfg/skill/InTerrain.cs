using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.skill
{
[System.Serializable]
public  class InTerrain : BuffTriggerType
 {




    public const int TYPE_ID = 32625;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public InTerrain(Perfect.Marshal.Octets os) : base(os)  {

    }

    public InTerrain()
    {
    }

    public InTerrain(XmlElement e)
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
        ele.WriteAttributeString("type", "InTerrain");
    }


}
}
}
