<<<<<<< HEAD
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private Text _timerText;
    [SerializeField] private float _delay = 0.5f;

    private float _curretntTime = 0f;
    private bool _isRunning = true;

    private Coroutine _counting;

    private void Start()
    {
        _counting = StartCoroutine(Count());
    }

    private void OnMouseDown()
    {
        Debug.Log("1");
        _isRunning = !_isRunning;

        if (_isRunning)
            _counting = StartCoroutine(Count());
        else
            StopCoroutine(_counting);
    }

    private IEnumerator Count()
    {
        WaitForSeconds delay = new WaitForSeconds(_delay);

        while (true) 
        {
            _curretntTime++;
            _timerText.text = _curretntTime.ToString();
            
            yield return delay;
        }
    }
=======
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private Text _timerText;
    [SerializeField] private float _delay = 0.5f;

    private float _curretntTime = 0f;
    private bool _isRunning = true;

    private Coroutine _counting;

    private void Start()
    {
        _counting = StartCoroutine(Count());
    }

    private void OnMouseDown()
    {
        Debug.Log("1");
        _isRunning = !_isRunning;

        if (_isRunning)
            _counting = StartCoroutine(Count());
        else
            StopCoroutine(_counting);
    }

    private IEnumerator Count()
    {
        WaitForSeconds delay = new WaitForSeconds(_delay);

        while (true) 
        {
            _curretntTime++;
            _timerText.text = _curretntTime.ToString();
            
            yield return delay;
        }
    }
>>>>>>> 2788056d1000dd919285ef334ac757c09ba3fa01
}