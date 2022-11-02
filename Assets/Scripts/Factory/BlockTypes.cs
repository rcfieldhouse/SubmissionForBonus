using System.Collections;
using System.Collections.Generic;
using UnityEngine;

internal class BlueBlock : BlockInterface
{
    public void Create(GameObject obj)
    {
    
        obj.GetComponent<Renderer>().materials[0].color = Color.blue;
    }
}
internal class OrangeBlock : BlockInterface  
{
    public void Create(GameObject obj)
    {
        obj.GetComponent<Renderer>().materials[0].color = Color.yellow;
    }
}
internal class GreenBlock : BlockInterface
{
    public void Create(GameObject obj)
    {
        obj.GetComponent<Renderer>().materials[0].color = Color.green;
    }
}
