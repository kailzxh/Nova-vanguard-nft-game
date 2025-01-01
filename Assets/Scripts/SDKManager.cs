using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Thirdweb;

public class SDKManager : MonoBehaviour
{
    public static SDKManager instance;
    public ThirdwebSDK SDK; // Keep the SDK reference as a public field for global access

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject); // Prevent duplicate instances
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // Persist the SDKManager across scenes
        }
    }

    void Start()
    {
        try
        {
            
            SDK = new ThirdwebSDK("sepolia"); 
            Debug.Log("Thirdweb SDK Initialized Successfully!");
        }
        catch (System.Exception ex)
        {
            Debug.Log($"Error initializing Thirdweb SDK: {ex.Message}");
        }
    }

    void Update()
    {
        // If you need periodic checks or updates
    }
}
