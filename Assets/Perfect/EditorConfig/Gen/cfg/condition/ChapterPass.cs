using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.condition
{
[System.Serializable]
public  class ChapterPass : Condition
 {

    public int chapterId ;
     



    public const int TYPE_ID = 52819;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public ChapterPass(Perfect.Marshal.Octets os) : base(os)  {

        chapterId = os.ReadInt(); 
         
    }

    public ChapterPass()
    {
    }

    public ChapterPass(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "chapterId":  chapterId = ele.ReadInt(); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "ChapterPass");
        ele.WriteStartElement("chapterId"); ele.WriteInt(chapterId); ele.WriteEndElement();
         
    }


}
}
}
