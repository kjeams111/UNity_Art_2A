using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static STORYGAME.StoryTableObject;
using static STORYGAME.Exnums;



[CreateAssetMenu(fileName = "NewStory", menuName = "SriptableObjects/StoryModel")]
public class StoryModel : ScriptableObject
{
    public int storyNumber;
    public Texture2D MainImage;

    public enum STORYTYPE //스토리 타입 설정
    {
        MAIN,
        SUB,
        SERIAL
    }

    public STORYTYPE storytype;
    public bool storyDone;

    [TextArea(10, 10)] //텍스트 영역  표시
    public string storyText;   //메인 스토리

    public Option[] options; //선택지 배열

    [System.Serializable]

    public class Option
    {
        public string optionText;
        public string buttonText;

    }


    [System.Serializable]

    public class EventCheck
    {
        public int checkValue;

        public enum EventType : int
        {
            NONE,
            GoToBattle,
            CheckSTR,
            CheckDEX,
            CheckCON,
            CheckINT,
            CheckWIS,
            CheckCHA
        }

        public EventType eventType;
        public Result[] suceessResult;
        public Result[] failResult;
    }
    [System.Serializable]

    public class Result
    {
        public enum ResultType : int
        {
            ChangeHp,
            ChangeSP,
            AddExerience,
            GoToShop,
            GoToNextStory,
            GoToRandomStory,
            GotoEnding

        }

        public ResultType resultType;
        public int value;
        public Stats stats; //해당 스텟 변화 수치
    }

}
