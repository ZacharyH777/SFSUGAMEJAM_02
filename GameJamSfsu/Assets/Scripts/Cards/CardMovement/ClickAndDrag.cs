using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickAndDrag : MonoBehaviour
{
    private Vector3 offset;  
    private bool is_dragging = false;
    private Camera cam;     
    private float base_lerp_speed = 20f; 
    private float size_animation_scale = 8f; 

    private Vector3 max_card_size;
    private Vector3 original_card_size;

    void Start()
    {
        original_card_size = transform.localScale;
        max_card_size = new Vector3(3f, 4.5f, 0f); 
        cam = Camera.main;

        if (cam == null)
        {
            Debug.LogError("Main Camera not found. Ensure your scene has a Camera tagged as 'MainCamera'.");
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mouse_pos = cam.ScreenToWorldPoint(Input.mousePosition);
            Collider2D hit_collider = Physics2D.OverlapPoint(mouse_pos);

            if (hit_collider != null && hit_collider.gameObject == gameObject)
            {
                is_dragging = true;
                offset = transform.position - cam.ScreenToWorldPoint(Input.mousePosition);
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            is_dragging = false;
        }

        if (is_dragging)
        {
            transform.localScale = Vector3.Lerp(transform.localScale, max_card_size, size_animation_scale * Time.deltaTime);

            Vector3 target_pos = cam.ScreenToWorldPoint(Input.mousePosition) + offset;
            target_pos.z = transform.position.z;

            float distance = Vector3.Distance(transform.position, target_pos); 
            float dynamic_lerp_speed = base_lerp_speed * Mathf.Clamp(distance, 8f, 20f); 

            transform.position = Vector3.Lerp(transform.position, target_pos, dynamic_lerp_speed * Time.deltaTime);
        }
        else if (Vector3.Distance(transform.localScale, original_card_size) > 0.001f)
        {
            transform.localScale = Vector3.Lerp(transform.localScale, original_card_size, size_animation_scale * Time.deltaTime * 6f);

            if (Vector3.Distance(transform.localScale, original_card_size) < 0.01f)
            {
                transform.localScale = original_card_size;
            }
        }
    }
}