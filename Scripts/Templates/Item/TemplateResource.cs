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
using WoCo.DungeonCrawler;

namespace WoCo.DungeonCrawler {

	// ===================================================================================
	// TEMPLATE RESOURCE
	// ===================================================================================
    [Serializable]
    [CreateAssetMenu(fileName = "Resource", menuName = "RDCK/Templates/Items/New Resource")]
    public class TemplateResource : TemplateAdvanced {
    
		public CurrencyType currencyType;

    }
    
    // ===================================================================================
    
}