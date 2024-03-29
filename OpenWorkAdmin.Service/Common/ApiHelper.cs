﻿using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

using OpenWorkAdmin.Domain.Common;
using OpenWorkAdmin.Service.Utils;

namespace OpenWorkAdmin.Service.Common;

public class ApiHelper
{
	private readonly HttpClient _client = new();
	private readonly string ip = "http://65.2.141.175";

	public async Task<RequestResult> DeleteAsync(string query)
	{
		HttpResponseMessage request = await _client.DeleteAsync(ip + query);
		return new RequestResult(await request.Content.ReadAsStringAsync(), request.StatusCode);
	}

	public async Task<RequestResult> GetAsync(string query)
	{
		HttpResponseMessage request = await _client.GetAsync(ip + query);
		return new RequestResult(await request.Content.ReadAsStringAsync(), request.StatusCode);
	}

	public async Task<RequestResult> PostAsync<T>(string query, T obj) where T : Dto
	{
		HttpResponseMessage request = await _client.PostAsJsonAsync(ip + query, obj);
		return new RequestResult(await request.Content.ReadAsStringAsync(), request.StatusCode);
	}

	public async Task<RequestResult> PostAsync(string query)
	{
		HttpResponseMessage request = await _client.PostAsync(ip + query, null);
		return new RequestResult(await request.Content.ReadAsStringAsync(), request.StatusCode);
	}

	public async Task<RequestResult> PutAsync<T>(string query, T obj) where T : Dto
	{
		HttpResponseMessage request = await _client.PutAsJsonAsync(ip + query, obj);
		return new RequestResult(await request.Content.ReadAsStringAsync(), request.StatusCode);
	}

	public async Task<RequestResult> PatchAsync(string query)
	{
		HttpResponseMessage request = await _client.PatchAsync(ip + query, null);
		return new RequestResult(await request.Content.ReadAsStringAsync(), request.StatusCode);
	}
}
