using System;

/// <summary>
/// 开发人员标注特性
/// </summary>
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
public class DevelopAuthorAttribute : Attribute
{
    public string develop_author;
    public string develop_message;
    /// <param name="develop_author">开发作者</param>
    /// <param name="develop_message">开发信息</param>
    public DevelopAuthorAttribute(string develop_author,string develop_message)
    {  
        this.develop_author = develop_author;
        this.develop_message = develop_message;
    }
}




