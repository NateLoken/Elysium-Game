﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject artemisPiece, aresPiece, demeterPiece, hadesPiece, hermesPiece, posiedonPiece, zeusPiece;
    public Board mBoard;

    public PieceManager mPieceManager;
    // Start is called before the first frame update
    void Start()
    {
        mBoard.Create();
        mPieceManager.Setup(mBoard);
//        /*
//        Instantiate(aresPiece);
//        Instantiate(demeterPiece);
//        Instantiate(hadesPiece);
//        Instantiate(hermesPiece);
//        Instantiate(posiedonPiece);
//        */
//        Instantiate(zeusPiece);
        
    }

    private void Update()
    {
        
    }

}
