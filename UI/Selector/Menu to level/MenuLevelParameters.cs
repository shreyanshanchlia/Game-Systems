using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

namespace SDG
{
    [System.Serializable]
    public struct LevelParameters
	{
        public string title;
        //set all variables here
        public Sprite sprite;
	};
    public class MenuLevelParameters : MonoBehaviour
    {
        public List<LevelParameters> SelectableItems;
        public HorizontalSelector horizontalSelector;

        [Header("Link to UI variables.")]
        public Image image;

		public void SetValues()
		{

		}
    }
}
