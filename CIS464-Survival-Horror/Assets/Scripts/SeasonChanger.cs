using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeasonChanger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public GameObject[] FloorTiles;
    public GameObject[] RoadTilesR;
    public GameObject[] RoadTilesL;
    public GameObject[] TreeTiles;

    // Update is called once per frame

    // Floor Tiles
    public Sprite spriteSpringFloor;
    public Sprite spriteFallFloor;
    public Sprite spriteWinterFloor;
    public Sprite spriteSummerFloor;

    // Road Tiles
    public Sprite spriteSpringRoadL;
    public Sprite spriteFallRoadL;
    public Sprite spriteWinterRoadL;
    public Sprite spriteSummerRoadL;

    // Road Tiles
    public Sprite spriteSpringRoadR;
    public Sprite spriteFallRoadR;
    public Sprite spriteWinterRoadR;
    public Sprite spriteSummerRoadR;

    // Tree Tiles
    public Sprite spriteSpringTree;
    public Sprite spriteFallTree;
    public Sprite spriteWinterTree;
    public Sprite spriteSummerTree;

    void Update()
    {
        FloorTiles = GameObject.FindGameObjectsWithTag("Floor");
        RoadTilesR = GameObject.FindGameObjectsWithTag("RoadR");
        RoadTilesL = GameObject.FindGameObjectsWithTag("RoadL");            
        TreeTiles = GameObject.FindGameObjectsWithTag("Tree");
   
        if (Input.GetKeyDown("1")) // Spring
        {
            foreach (GameObject FloorTile in FloorTiles)
            {
                FloorTile.GetComponentInChildren<SpriteRenderer>().sprite = spriteSpringFloor;
            }

            foreach (GameObject RoadTileR in RoadTilesR)
            {
                RoadTileR.GetComponentInChildren<SpriteRenderer>().sprite = spriteSpringRoadR;
            }

            foreach (GameObject RoadTileL in RoadTilesL)
            {
                RoadTileL.GetComponentInChildren<SpriteRenderer>().sprite = spriteSpringRoadL;
            }

            foreach (GameObject TreeTile in TreeTiles)
            {
                TreeTile.GetComponentInChildren<SpriteRenderer>().sprite = spriteSpringTree;
            }

        }
        else if (Input.GetKeyDown("2")) // Fall
        {
            foreach (GameObject FloorTile in FloorTiles)
            {
                FloorTile.GetComponentInChildren<SpriteRenderer>().sprite = spriteFallFloor;
            }

            foreach (GameObject RoadTileR in RoadTilesR)
            {
                RoadTileR.GetComponentInChildren<SpriteRenderer>().sprite = spriteFallRoadR;
            }

            foreach (GameObject RoadTileL in RoadTilesL)
            {
                RoadTileL.GetComponentInChildren<SpriteRenderer>().sprite = spriteFallRoadL;
            }

            foreach (GameObject TreeTile in TreeTiles)
            {
                TreeTile.GetComponentInChildren<SpriteRenderer>().sprite = spriteFallTree;
            }
        }
        else if (Input.GetKeyDown("3"))
        {
            foreach (GameObject FloorTile in FloorTiles)
            {
                FloorTile.GetComponentInChildren<SpriteRenderer>().sprite = spriteWinterFloor;
            }

            foreach (GameObject RoadTileR in RoadTilesR)
            {
                RoadTileR.GetComponentInChildren<SpriteRenderer>().sprite = spriteWinterRoadR;
            }

            foreach (GameObject RoadTileL in RoadTilesL)
            {
                RoadTileL.GetComponentInChildren<SpriteRenderer>().sprite = spriteWinterRoadL;
            }

            foreach (GameObject TreeTile in TreeTiles)
            {
                TreeTile.GetComponentInChildren<SpriteRenderer>().sprite = spriteWinterTree;
            }
        }
        else if (Input.GetKeyDown("4"))
        {
            foreach (GameObject FloorTile in FloorTiles)
            {
                FloorTile.GetComponentInChildren<SpriteRenderer>().sprite = spriteSummerFloor;
            }

            foreach (GameObject RoadTileR in RoadTilesR)
            {
                RoadTileR.GetComponentInChildren<SpriteRenderer>().sprite = spriteSummerRoadR;
            }

            foreach (GameObject RoadTileL in RoadTilesL)
            {
                RoadTileL.GetComponentInChildren<SpriteRenderer>().sprite = spriteSummerRoadL;
            }

            foreach (GameObject TreeTile in TreeTiles)
            {
                TreeTile.GetComponentInChildren<SpriteRenderer>().sprite = spriteSummerTree;
            }
        }

    }
}

