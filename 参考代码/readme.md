>该项目中默认采用了读取`硬盘序列号`的方式作为机器码，不过有些情况可能CPU、网卡比较适用，所以在这里总结了一些代码，方便查阅。


## cpu序列号
```
ManagementClass cimobject = new ManagementClass("Win32_Processor");
ManagementObjectCollection moc = cimobject.GetInstances();
foreach (ManagementObject mo in moc)
{
	cpuInfo = mo.Properties["ProcessorId"].Value.ToString();
}
```

## 硬盘序列号
```
ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMedia");
String strHardDiskID = null;//存储磁盘序列号
foreach (ManagementObject mo in searcher.Get())
{
	strHardDiskID = mo["SerialNumber"].ToString().Trim();//记录获得的磁盘序列号
}
```

## 网卡Mac地址
```
ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
ManagementObjectCollection moc2 = mc.GetInstances();
foreach (ManagementObject mo in moc2)
{
	if ((bool)mo["IPEnabled"] == true)
	{	
		txtContent.Text += mo["MacAddress"].ToString();
	}
}
```

