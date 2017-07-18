
using UnityEngine;

namespace Dal.Examples
{    
    [ExecuteInEditMode]                                                         // Name this script "DiscHandle"
    public class Disc : MonoBehaviour
    {
        public Quaternion rot = Quaternion.identity;
        public void Update()
        {
            transform.rotation = rot;
        }
    }
}

#region References
// From https://docs.unity3d.com/ScriptReference/PrimitiveType.Quad.html
#endregion