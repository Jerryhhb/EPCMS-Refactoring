🏭 设备管理系统 (Device Management System)
基于 C# WinForms 开发的轻量级工业设备台账管理软件。本项目旨在通过标准的三层架构与工程化开发规范，实现设备信息的高效管理与数据持久化，为工业上位机开发提供一套可参考的底层骨架。

🛠️ 技术栈 (Tech Stack)
UI 框架：WinForms + [CSkin 皮肤库]

ORM 框架：Dapper (高性能轻量级 ORM)

数据库：SQLite (本地免安装轻量级数据库)

日志组件：NLog (全局异常拦截与业务日志记录)

架构思想：三层架构 (UI - BLL - DAL)、依赖注入 (DI)、面向接口编程

🏗️ 架构设计 (Architecture)
项目严格按照分层架构设计，彻底解耦 UI 界面与底层数据访问：

Views (UI 层)：只负责界面展示、收集用户输入、调用业务层服务。

BLL (业务逻辑层)：处理设备管理业务逻辑，进行数据校验。

DAL (数据访问层)：基于 Dapper 封装 SqliteHelper，负责纯粹的数据库增删改查。

Models (实体层)：数据模型 DTO，在各层之间传递数据。

Utils (工具层)：封装 NLog 全局日志工具、通用扩展方法。

🚀 核心特性 (Features)
数据 CRUD：支持设备信息的添加、修改、删除、按名称模糊查询与列表展示。

全局异常处理：在 Program.cs 入口处挂载 Application.ThreadException 全局异常拦截器，配合 NLog 记录崩溃日志，保证程序不闪退且现场可追溯。

依赖注入解耦：通过构造函数注入（Constructor Injection）将底层 Helper 传递给业务层，实现了底层数据库（未来可从 SQLite 无缝替换为 MySQL/SQL Server）的随时插拔。

UI 美化：集成 CSkin 第三方皮肤，摆脱原生 WinForm 的陈旧感。
