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

    public enum STORYTYPE //���丮 Ÿ�� ����
    {
        MAIN,
        SUB,
        SERIAL
    }

    public STORYTYPE storytype;
    public bool storyDone;

    [TextArea(10, 10)] //�ؽ�Ʈ ����  ǥ��
    public string storyText;   //���� ���丮

    public Option[] options; //������ �迭

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
        public Stats stats; //�ش� ���� ��ȭ ��ġ
    }

}
