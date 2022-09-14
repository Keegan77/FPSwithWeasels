using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnoreStarColl : MonoBehaviour
{
    CapsuleCollider playerColl;
    public BoxCollider ninjaStar;
    // Start is called before the first frame update
    void Start()
    {
        playerColl = GetComponent<CapsuleCollider>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ninjaStar != null)
        {
            Physics.IgnoreCollision(playerColl, ninjaStar);
        } // if ninja star exists, ignore coll
        
    }
}
