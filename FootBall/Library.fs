namespace Football

open UnityEngine

type TestFuture() =
   inherit MonoBehaviour()
   
   [<SerializeField>]
   [<DefaultValue>] val mutable _informationText : GameObject

    member this.Start() = 
        Debug.Log("Say hello from FSharp 222 ")

    member this.Update() = 
        Debug.Log "Enter new scene"

