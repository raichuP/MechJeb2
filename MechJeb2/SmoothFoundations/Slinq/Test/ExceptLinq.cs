using UnityEngine;
using System.Linq;

#if !UNITY_3_5
namespace Smooth.Slinq.Test {
#endif
	
	public class ExceptLinq : MonoBehaviour {
		private void Update() {
			for (int i = 0; i < SlinqTest.loops; ++i) {
				SlinqTest.tuples1.Except(SlinqTest.tuples2, SlinqTest.eq_1).Count();
			}
		}
	}

#if !UNITY_3_5
}
#endif
