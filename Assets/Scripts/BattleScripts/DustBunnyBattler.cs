using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustBunnyBattler : EnemyBattler
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public IEnumerator Attack1()
    {
        yield return new WaitForSeconds(1);
    }
}