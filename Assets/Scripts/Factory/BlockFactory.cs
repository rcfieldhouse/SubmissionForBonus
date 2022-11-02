using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
internal enum BlockType
{
    Blue, Orange, Green
}
internal class BlockFactory
{

    public static BlockInterface CreateBlock(BlockType type)
    {
        BlockInterface Block;
        switch (type)
        {
            case BlockType.Blue:
                Block = new BlueBlock();
                break;
            case BlockType.Green:
                Block = new GreenBlock();
                break;
            case BlockType.Orange:
                Block = new OrangeBlock();
                break;

            default:
                Block = new BlueBlock();
                break;
        }
        return Block;

    }
  
}
