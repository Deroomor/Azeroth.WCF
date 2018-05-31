# Azeroth.WCF
`System.ServiceModel`类库的使用方法示例

* 基于wcf类库实现标准的webservice
  * 服务端
  * 客户端

* 基于wcf类库实现webapi
  * 服务端,项目`Klz.API`,配置文件，`System.ServiceModel.Web.WebServiceHost`
  * 跨域，基于`CORS`协议，添加一个方法，使用`System.ServiceModel.Web.WebInvoke(Method = "OPTIONS", UriTemplate = "*")`修饰，处理跨域的OPTIONS请求，向响应头增加CORS协议约定的值， `System.ServiceModel.Web.WebOperationContext.Current`类似于asp.net的`HttpContext`
  * 全局异常处理，为每个终结点的behavior增加一个异常处理Hanlder,参看`ErrorHandlerHookAttribute`
  * 终结点behavior，`helpEnabled=true`则自动生成api的说明文档，`automaticFormatSelectionEnabled=true`响应格式自动切换,这两个值默认是`false`
  * `T4`项目测试api的跨域，全局异常
* 使用`System.ServiceProcess`把wcf寄宿在Windows服务
