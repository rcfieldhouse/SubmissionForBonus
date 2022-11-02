using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSelect : MonoBehaviour
{
    [SerializeField] BlockType BlockChoice;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Awake()
    {
        CreateBlock();
    }
    void CreateBlock()
    {
        BlockInterface block = BlockFactory.CreateBlock(BlockChoice);
        block.Create(gameObject);
    }
}
