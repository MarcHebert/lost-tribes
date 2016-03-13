using UnityEngine;
using System.Collections;
[System.Serializable]
public abstract class QuestItem : Item {
    private int questID; //TODO: create script for quests to utilize questID, affecting village visibility and next available quest
}
