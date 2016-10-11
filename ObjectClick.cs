using UnityEngine;
using System.Collections;

public class ObjectClick : MonoBehaviour {

    public GameObject a; //삭제할 게임 오브젝트 지정을 위한 변수.
    public bool masterHand;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //마우스 클릭
        if (Input.GetMouseButtonUp(0))
        {
            //메인 카메라에서 레이를 쏴서 맞는 물체를 확인. (레이라는 것이 안보이는 광선인가 봄)
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //레이에 맞았는지 확인하는 변수인가봄. (레이에 맞은 것?)
            RaycastHit hit;

            ////phsics = 물리 사용. 레이를 발사해서 앞으로 나아가다가 충돌체를 만나면 그 정보를 hit에 저장.
            if (Physics.Raycast(ray, out hit))
            {
                //이건 레이에 물건이 맞는지 확인. 로그인가 콘솔인가, 에러나는 그 창에 내가 클릭한 오브젝트가 뭔지 뜨게 됨.
                Debug.Log(hit.transform.name);
                //맞은 물건의 정보(오브젝트 정보?)를 a에 저장
                a = hit.transform.gameObject;
                //a삭제.

                if (masterHand)
                {
                    
                }
                else
                {
                    if (a.tag != "background")
                    {
                        Destroy(a);
                    }
                }
            }
        }
	}
}
