using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NuevaIaEnemiga : MonoBehaviour
{
    [SerializeField] public float radioBusqueda;

    [SerializeField] public LayerMask capaJugador;

    [SerializeField] public Transform transformJugador;

    [SerializeField] public float enemySpeed;

    [SerializeField] public float FuerzSalto = 8.0f;

    private Rigidbody2D fisica;





    // Start is called before the first frame update
    void Start()
    {
        fisica = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        Collider2D jugadorCollider = Physics2D.OverlapCircle(transform.position, radioBusqueda, capaJugador);

        Ray2D ray2D = new Ray2D(transform.position, transformJugador.position );
        Debug.DrawRay(ray2D.origin, ray2D.direction);


        if (jugadorCollider)
        {
            transform.position = Vector2.MoveTowards(transform.position, transformJugador.position, enemySpeed * Time.deltaTime);

            //if()
            {
                 //fisica.AddForce(new Vector2(0, FuerzSalto), ForceMode2D.Impulse);
            }


        }

       

          


    }


    public void OnDrawGizmos()
    {

        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, radioBusqueda);
        
    }

    


}
