using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Singleton Monobehavior
public class SingletonMonobehavior<T> : MonoBehaviour
where T : SingletonMonobehavior<T>
{
    private T ins;
    public T Ins
    {
        get => ins;
        private set => ins = value;
    }
    void Awake()
    {
        if (Ins == null)
        {
            Ins = (T)this;
            this.UnityAwake();
        }
        else if (Ins != this)
        {
            GameObject.Destroy(this.gameObject);
        }
    }

    protected virtual void UnityAwake() { }

    void OnDestroy()
    {
        if (Ins == this)
        {
            GameObject.Destroy(this.gameObject);
        }
    }
}
