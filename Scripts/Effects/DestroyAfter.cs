// =======================================================================================
// RETRO DUNGEON CRAWLER KIT (Support Forum: www.dungeoncrawler.net)
//
//   --- DO NOT CHANGE ANYTHING BELOW THIS LINE (UNLESS YOU KNOW WHAT YOU ARE DOING) ---
// =======================================================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace WoCo.DungeonCrawler {

	// ===================================================================================
	// DestroyAfter
	// ===================================================================================
    public class DestroyAfter : MonoBehaviour {
        
        public float destroyAfter = 1;
        
		// -------------------------------------------------------------------------------
		// 
		// -------------------------------------------------------------------------------    
        private void OnEnable() {
            if (destroyAfter > 0)
				Destroy(gameObject, destroyAfter);
        }
        
        // -------------------------------------------------------------------------------   
        
    }
}