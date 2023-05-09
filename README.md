# JsonStudy
learn json  file
JSON 对象
对象语法

实例
{ "name":"runoob", "alexa":10000, "site":null }
JSON 对象使用在大括号 {...} 中书写。

对象可以包含多个 key/value（键/值）对。

key 必须是字符串，value 可以是合法的 JSON 数据类型（字符串, 数字, 对象, 数组, 布尔值或 null）。

key 和 value 中使用冒号 : 分割。

每个 key/value 对使用逗号 , 分割。

访问对象值
你可以使用点号 . 来访问对象的值：

实例
var myObj, x;
myObj = { "name":"runoob", "alexa":10000, "site":null };
x = myObj.name;


你也可以使用中括号（[]）来访问对象的值：
实例
var myObj, x;
myObj = { "name":"runoob", "alexa":10000, "site":null };
x = myObj["name"];

JSON 数组在中括号中书写。

中括号 [] 保存的数组是值（value）的有序集合。一个数组以左中括号 [ 开始， 右中括号 ] 结束，值之间使用逗号 , 分隔。

JSON 中数组值必须是合法的 JSON 数据类型（字符串, 数字, 对象, 数组, 布尔值或 null）。

JavaScript 中，数组值可以是以上的 JSON 数据类型，也可以是 JavaScript 的表达式，包括函数，日期，及 undefined。

JSON 对象中的数组
对象属性的值可以是一个数组：
实例
{
"name":"网站",
"num":3,
"sites":[ "Google", "Runoob", "Taobao" ]
}
我们可以使用索引值来访问数组：
实例
x = myObj.sites[0];