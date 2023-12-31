﻿using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using H_W_Mod4_1.ReqresApiHw;
using Newtonsoft.Json.Serialization;

namespace H_W_Mod4_1.ReqresApiHw;
internal static class ReqresApi
{
    private const string RequesURL = "https://reqres.in/";

    public static async Task ReqresModelsExampleAsync1()
    {
        using var client = new HttpClient();
        client.BaseAddress = new Uri(RequesURL);

        HttpResponseMessage result = await client.GetAsync("/api/users?page=2");

        if (result.StatusCode == HttpStatusCode.OK)
        {
            Console.WriteLine("Ok Code from reqres site.");
            string content = await result.Content.ReadAsStringAsync();
            Console.WriteLine(content);
            ReqresPageResponse pageRequest = JsonConvert.DeserializeObject<ReqresPageResponse>(content);

            if (pageRequest is not null)
            {
                Console.WriteLine(pageRequest.ToString());
            }
        }
    }

    public static async Task ReqresModelsExampleAsync2()
    {
        using var client = new HttpClient();
        client.BaseAddress = new Uri(RequesURL);

        HttpResponseMessage result = await client.GetAsync("/api/users/2");

        if (result.StatusCode == HttpStatusCode.OK)
        {
            Console.WriteLine("Ok Code from reqres site.");
            string content = await result.Content.ReadAsStringAsync();
            Console.WriteLine(content);
            ReqresPageResponse pageRequest = JsonConvert.DeserializeObject<ReqresPageResponse>(content);

            if (pageRequest is not null)
            {
                Console.WriteLine(pageRequest.ToString());
            }
        }
    }

    public static async Task ReqresModelsExampleAsync3()
    {
        using var client = new HttpClient();
        client.BaseAddress = new Uri(RequesURL);

        HttpResponseMessage result = await client.GetAsync("/api/users/23");

        if (result.StatusCode == HttpStatusCode.OK)
        {
            Console.WriteLine("Ok Code from reqres site.");
            string content = await result.Content.ReadAsStringAsync();
            Console.WriteLine(content);
            ReqresPageResponse pageRequest = JsonConvert.DeserializeObject<ReqresPageResponse>(content);

            if (pageRequest is not null)
            {
                Console.WriteLine(pageRequest.ToString());
            }
        }
    }

    public static async Task ReqresModelsExampleAsync4()
    {
        using var client = new HttpClient();
        client.BaseAddress = new Uri(RequesURL);

        HttpResponseMessage result = await client.GetAsync("/api/unknown");

        if (result.StatusCode == HttpStatusCode.OK)
        {
            Console.WriteLine("Ok Code from reqres site.");
            string content = await result.Content.ReadAsStringAsync();
            Console.WriteLine(content);
            ReqresPageResponse pageRequest = JsonConvert.DeserializeObject<ReqresPageResponse>(content);

            if (pageRequest is not null)
            {
                Console.WriteLine(pageRequest.ToString());
            }
        }
    }

    public static async Task ReqresModelsExampleAsync5()
    {
        using var client = new HttpClient();
        client.BaseAddress = new Uri(RequesURL);

        HttpResponseMessage result = await client.GetAsync("/api/unknown/2");

        if (result.StatusCode == HttpStatusCode.OK)
        {
            Console.WriteLine("Ok Code from reqres site.");
            string content = await result.Content.ReadAsStringAsync();
            Console.WriteLine(content);
            ReqresPageResponse pageRequest = JsonConvert.DeserializeObject<ReqresPageResponse>(content);

            if (pageRequest is not null)
            {
                Console.WriteLine(pageRequest.ToString());
            }
        }
    }

    public static async Task ReqresModelsExampleAsync6()
    {
        using var client = new HttpClient();
        client.BaseAddress = new Uri(RequesURL);

        HttpResponseMessage result = await client.GetAsync("/api/unknown/23");

        if (result.StatusCode == HttpStatusCode.OK)
        {
            Console.WriteLine("Ok Code from reqres site.");
            string content = await result.Content.ReadAsStringAsync();
            Console.WriteLine(content);
            ReqresPageResponse pageRequest = JsonConvert.DeserializeObject<ReqresPageResponse>(content);

            if (pageRequest is not null)
            {
                Console.WriteLine(pageRequest.ToString());
            }
        }
    }

    public static async Task ReqresModelsExampleAsync7()
    {
        using var client = new HttpClient();
        client.BaseAddress = new Uri(RequesURL);

        var userParametersRequest = new CreateUserParametersRequest
        {
            Name = "Morpheus",
            Job = "Leader"
        };

        string serializedUser = JsonConvert.SerializeObject(userParametersRequest, new JsonSerializerSettings
        {
            ContractResolver = new DefaultContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy()
            }
        });

        var stringContent = new StringContent(serializedUser, Encoding.Unicode, "application/json"); // application/json - required.

        HttpResponseMessage result = await client.PostAsync("api/users", stringContent);

        if (result.StatusCode == HttpStatusCode.Created)
        {
            Console.WriteLine("StatusCode: Created");

            string content = await result.Content.ReadAsStringAsync();
            Console.WriteLine(content);

            UserCreatedResponse userCreatedResponse = JsonConvert.DeserializeObject<UserCreatedResponse>(content);
            Console.WriteLine(userCreatedResponse!.Name);
            Console.WriteLine(userCreatedResponse!.Job);
        }
    }

    public static async Task ReqresModelsExampleAsync8()
    {
        using var client = new HttpClient();
        client.BaseAddress = new Uri(RequesURL);

        var userParametersRequest = new CreateUserParametersRequest
        {
            Name = "Morpheus",
            Job = "Zion Resident"
        };

        string serializedUser = JsonConvert.SerializeObject(userParametersRequest, new JsonSerializerSettings
        {
            ContractResolver = new DefaultContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy()
            }
        });

        var stringContent = new StringContent(serializedUser, Encoding.Unicode, "application/json"); // application/json - required.

        HttpResponseMessage result = await client.PutAsync("api/users/2", stringContent);

        if (result.StatusCode == HttpStatusCode.OK)
        {
            Console.WriteLine("StatusCode: Puted");

            string content = await result.Content.ReadAsStringAsync();
            Console.WriteLine(content);

            UserCreatedResponse userCreatedResponse = JsonConvert.DeserializeObject<UserCreatedResponse>(content);
            Console.WriteLine(userCreatedResponse!.Name);
            Console.WriteLine(userCreatedResponse!.Job);
        }
    }

    public static async Task ReqresModelsExampleAsync9()
    {
        using var client = new HttpClient();
        client.BaseAddress = new Uri(RequesURL);

        var userParametersRequest = new CreateUserParametersRequest
        {
            Name = "Morpheus",
            Job = "Zion Resident"
        };

        string serializedUser = JsonConvert.SerializeObject(userParametersRequest, new JsonSerializerSettings
        {
            ContractResolver = new DefaultContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy()
            }
        });

        var stringContent = new StringContent(serializedUser, Encoding.Unicode, "application/json"); // application/json - required.

        HttpResponseMessage result = await client.PatchAsync("api/users/2", stringContent);

        if (result.StatusCode == HttpStatusCode.OK)
        {
            Console.WriteLine("StatusCode: Patched");

            string content = await result.Content.ReadAsStringAsync();
            Console.WriteLine(content);

            UserCreatedResponse userCreatedResponse = JsonConvert.DeserializeObject<UserCreatedResponse>(content);
            Console.WriteLine(userCreatedResponse!.Name);
            Console.WriteLine(userCreatedResponse!.Job);
        }
    }

    public static async Task ReqresModelsExampleAsync10()
    {
        using var client = new HttpClient();
        client.BaseAddress = new Uri(RequesURL);

        var userParametersRequest = new CreateUserParametersRequest
        {
            Name = "Morpheus",
            Job = "Zion Resident"
        };

        string serializedUser = JsonConvert.SerializeObject(userParametersRequest, new JsonSerializerSettings
        {
            ContractResolver = new DefaultContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy()
            }
        });

        var stringContent = new StringContent(serializedUser, Encoding.Unicode, "application/json"); // application/json - required.

        HttpResponseMessage result = await client.DeleteAsync("api/users/2");

        if (result.StatusCode == HttpStatusCode.NoContent)
        {
            Console.WriteLine("StatusCode: Deleted");

            string content = await result.Content.ReadAsStringAsync();
            Console.WriteLine(content);

            UserCreatedResponse userCreatedResponse = JsonConvert.DeserializeObject<UserCreatedResponse>(content);
        }
    }

    public static async Task ReqresModelsExampleAsync11()
    {
        using var client = new HttpClient();
        client.BaseAddress = new Uri(RequesURL);

        var userParametersRequest = new CreateUserParametersRequest
        {
            Email = "eve.holt@reqres.in",
            Password = "pistol"
        };

        string serializedUser = JsonConvert.SerializeObject(userParametersRequest, new JsonSerializerSettings
        {
            ContractResolver = new DefaultContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy()
            }
        });

        var stringContent = new StringContent(serializedUser, Encoding.Unicode, "application/json"); // application/json - required.

        HttpResponseMessage result = await client.PostAsync("api/register", stringContent);

        if (result.StatusCode == HttpStatusCode.OK)
        {
            Console.WriteLine("StatusCode: Register Successful");

            string content = await result.Content.ReadAsStringAsync();
            Console.WriteLine(content);

            UserCreatedResponse userCreatedResponse = JsonConvert.DeserializeObject<UserCreatedResponse>(content);
        }

    }

    public static async Task ReqresModelsExampleAsync12()
    {
        using var client = new HttpClient();
        client.BaseAddress = new Uri(RequesURL);

        var userParametersRequest = new CreateUserParametersRequest
        {
            Email = "sydney@fife"
        };

        string serializedUser = JsonConvert.SerializeObject(userParametersRequest, new JsonSerializerSettings
        {
            ContractResolver = new DefaultContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy()
            }
        });

        var stringContent = new StringContent(serializedUser, Encoding.Unicode, "application/json"); // application/json - required.

        HttpResponseMessage result = await client.PostAsync("api/register", stringContent);

        if (result.StatusCode == HttpStatusCode.BadRequest)
        {
            Console.WriteLine("StatusCode: Register Unsuccessful");

            string content = await result.Content.ReadAsStringAsync();
            Console.WriteLine(content);

            UserCreatedResponse userCreatedResponse = JsonConvert.DeserializeObject<UserCreatedResponse>(content);
        }

    }

    public static async Task ReqresModelsExampleAsync13()
    {
        using var client = new HttpClient();
        client.BaseAddress = new Uri(RequesURL);

        var userParametersRequest = new CreateUserParametersRequest
        {
            Email = "eve.holt@reqres.in",
            Password = "cityslicka"
        };

        string serializedUser = JsonConvert.SerializeObject(userParametersRequest, new JsonSerializerSettings
        {
            ContractResolver = new DefaultContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy()
            }
        });

        var stringContent = new StringContent(serializedUser, Encoding.Unicode, "application/json"); // application/json - required.

        HttpResponseMessage result = await client.PostAsync("api/login", stringContent);

        if (result.StatusCode == HttpStatusCode.OK)
        {
            Console.WriteLine("StatusCode: Login Successful");

            string content = await result.Content.ReadAsStringAsync();
            Console.WriteLine(content);

            UserCreatedResponse userCreatedResponse = JsonConvert.DeserializeObject<UserCreatedResponse>(content);
        }
    }

    public static async Task ReqresModelsExampleAsync14()
    {
        using var client = new HttpClient();
        client.BaseAddress = new Uri(RequesURL);

        var userParametersRequest = new CreateUserParametersRequest
        {
            Email = "peter@klaven"
        };

        string serializedUser = JsonConvert.SerializeObject(userParametersRequest, new JsonSerializerSettings
        {
            ContractResolver = new DefaultContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy()
            }
        });

        var stringContent = new StringContent(serializedUser, Encoding.Unicode, "application/json"); // application/json - required.

        HttpResponseMessage result = await client.PostAsync("api/login", stringContent);

        if (result.StatusCode == HttpStatusCode.BadRequest)
        {
            Console.WriteLine("StatusCode: Login Unsuccessful");

            string content = await result.Content.ReadAsStringAsync();
            Console.WriteLine(content);

            UserCreatedResponse userCreatedResponse = JsonConvert.DeserializeObject<UserCreatedResponse>(content);
        }
    }

    public static async Task ReqresModelsExampleAsync15()
    {
        
            using var client = new HttpClient();
            client.BaseAddress = new Uri(RequesURL);

            HttpResponseMessage result = await client.GetAsync("api/users?delay=3"); // https://reqres.in/api/users?page=2

            if (result.StatusCode == HttpStatusCode.OK)
            {
                Console.WriteLine("Ok Delay code from reqres site.");
                string content = await result.Content.ReadAsStringAsync();
                Console.WriteLine(content);
                ReqresPageResponse pageRequest = JsonConvert.DeserializeObject<ReqresPageResponse>(content);

                if (pageRequest is not null)
                {
                    Console.WriteLine(pageRequest.ToString());
                }
            }
        
    }

}