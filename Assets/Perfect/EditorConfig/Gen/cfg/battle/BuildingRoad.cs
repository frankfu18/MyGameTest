using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.battle
{
[System.Serializable]
public  class BuildingRoad : BuildingType
 {




    public const int TYPE_ID = 4992;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public BuildingRoad(Perfect.Marshal.Octets os) : base(os)  {

    }

    public BuildingRoad()
    {
    }

    public BuildingRoad(XmlElement e)
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
        ele.WriteAttributeString("type", "BuildingRoad");
    }


}
}
}
