using System.Collections;
using UnityEngine;

namespace DSI.Dcm.Dchi.PicShow {
	public class SphereCueCreater : MonoBehaviour {
		public GameObject prefabGo;
		public float sphereRadius = 1.0f;
		public float coilRadius=1.0f;
		private float angle = 0;
		private float coilangle = 0;
		void Start () {
			//CreateCubeAngle20 ();
			CreateMosquitoCoil();
		}
		void Update () { }
		public void CreateCubeAngle20 () {

			//20度生成一个圆
			for (angle = 0; angle < 360; angle += 20) {
				//先解决你物体的位置的问题
				// x = 原点x + 半径 * 邻边除以斜边的比例,   邻边除以斜边的比例 = cos(弧度) , 弧度 = 角度 *3.14f / 180f;   
				float x = sphereRadius * Mathf.Cos (angle * 3.14f / 180f);
				float y = sphereRadius * Mathf.Sin (angle * 3.14f / 180f);
				// 生成一个圆
				GameObject l_go = GameObject.CreatePrimitive (PrimitiveType.Cube);
				l_go.transform.parent = transform;
				l_go.name = "angle" + angle;
				//设置物体的位置Vector3三个参数分别代表x,y,z的坐标数  
				l_go.transform.position = new Vector3 (x, 0, y);
			}
		}
		// 生成螺旋   //原理 += 半径
		public void CreateMosquitoCoil () {
			// 每隔30度就生成一个小方块  
			for (int i = 0; i < 120; coilangle += 12, coilRadius += 0.5f, i++) {
				// 根据原点,角度,半径获取物体的位置.  x = 原点x + 半径 * 邻边除以斜边的比例  
				float x = coilRadius * Mathf.Cos (coilangle * 3.14f / 180f);
				float y = coilRadius * Mathf.Sin (coilangle * 3.14f / 180f);
				//我们将obj1初始化为一个Cube立方体，当然我们也可以初始化为其他的形状  
				GameObject l_go = GameObject.CreatePrimitive (PrimitiveType.Cube);
				l_go.transform.parent = transform;
				l_go.name = "coilangle" + coilangle;
				//设置物体的位置Vector3三个参数分别代表x,y,z的坐标数  
				l_go.transform.position = new Vector3 (x, 0, y);
			}
		}

	}
}