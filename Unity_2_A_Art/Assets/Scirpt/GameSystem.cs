using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.Text;
using UnityEngine.UI;

namespace STORYGAME
{
#if UNITY_EDITOR
    [CustomEditor(typeof(GameSystem))]

    public class GameSystemEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            GameSystem gameSystem = (GameSystem)target;

            if (GUILayout.Button("Reset Story Models"))
            {
                gameSystem.ResetStoryModels();
            }

            if (GUILayout.Button("Assing Text Component by Name"))
            {
                //������Ʈ �̸����� Text ������Ʈ ã��
                GameObject textObject = GameObject.Find("StoryTextUI");
                if(textObject != null)
                {
                    Text textComponent = textObject.GetComponent<Text>();
                    {
                        gameSystem.textComponent = textComponent;
                        Debug.Log("Text Component assigned Successfully");
                    }
                }
            
            

            }
        }
    }
#endif
    public class GameSystem : MonoBehaviour
    {
        public static GameSystem instance;
        public Text textComponent = null;

        public float delay = 0.1f;
        public string fullText;
        public string currentText = "";

        public enum GAMESTATE
        {
          STORYSHOW,
          WAITSELCET,
          STORYEND,
          ENDMODE
        
        }

        public GAMESTATE currenState;
        public StoryTableObject[] storyModels;
        public StoryTableObject currentModels;
        public int currentStoryIndex;




        private void Awake()
        {
            instance = this;


        }

        public void Start()
        {
            StartCoroutine(ShowText());
        }

        IEnumerator ShowText()
        {
            for(int i = 0; i <= currentModels.storyText.Length; i++)
            {
                currentText = currentModels.storyText.Substring(0, i);
                textComponent.text = currentText;
                yield return new WaitForSeconds(delay);

            }
            yield return new WaitForSeconds(delay);
        }



      

#if UNITY_EDITOR
        [ContextMenu("Reset Story Models")]

        public void ResetStoryModels()
        {
            storyModels = Resources.LoadAll<StoryTableObject>("");



        }
#endif


    }
    



}



