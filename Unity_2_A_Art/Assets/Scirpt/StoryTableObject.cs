using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static STORYGAME.Exnums;

namespace STORYGAME
{
    [CreateAssetMenu(fileName = "NewStory", menuName = "SriptableObjects/StoryTableObject")]

    public class StoryTableObject : ScriptableObject
    {
        public int storyNumber;
        public Exnums.StoryType storyType; //스토리 타입 설정
        public bool storyDone;

        [TextArea(10, 10)]
        public string storyText;

        [System.Serializable]

        public class EventCheck
        {
            public int checkValue;
            public Exnums.EvenType eventType;
            public List<Result> successResult = new List<Result>();
            public List<Result> failResult = new List<Result>();
        }
            [System.Serializable]
        public class Option
        {
            public string optionText;
            public string buttonText;

        }

        [System.Serializable]

        public class Result
        {
            public Exnums.ResultType resultType;
            public int value;
            public Stats stats;
        }


    }
}
