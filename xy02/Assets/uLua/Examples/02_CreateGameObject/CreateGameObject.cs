using UnityEngine;
using System.Collections;
using LuaInterface;

public class CreateGameObject : MonoBehaviour {

    private string script = @"
            luanet.load_assembly('UnityEngine')
			luanet.load_assembly('Assembly-CSharp')
			
			Demo = luanet.import_type('Demo')
			Camera = luanet.import_type('UnityEngine.Camera')
			Vector3 = luanet.import_type('UnityEngine.Vector3');
			Resources = luanet.import_type('UnityEngine.Resources')
            GameObject = luanet.import_type('UnityEngine.GameObject')

            local go = GameObject('NewObj')
            go:AddComponent('Demo')

			Demo.echo('echoaaa---------------------------------->>>>');	--print--
			Demo.instance();

			local camera = GameObject.Find('Camera');
			go.transform.parent = camera.transform;
			go.transform.localScale = Vector3.one;
			local texture = go:AddComponent('UITexture');
			texture.mainTexture = Resources.Load('ipad');
			texture:MakePixelPerfect();
        ";

	// Use this for initialization
	void Start () {
        LuaState l = new LuaState();
		l.DoString(script); 
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
