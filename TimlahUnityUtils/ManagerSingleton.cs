namespace TimlahUnityUtils;

using UnityEngine;

public class ManagerSingleton<T> : MonoBehaviour where T : Component
{
        public static T _instance {get; private set;}

    void Awake() {
        if(_instance != null && _instance != this as T){Destroy(this as T);}else{_instance = this as T;}
    }        
}
