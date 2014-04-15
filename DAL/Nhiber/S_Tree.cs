<?xml version="1.0"?>
<sqlMap xmlns="http://ibatis.apache.org/mapping" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" namespace="S_Tree">
    <alias>
    <typeAlias alias="S_Tree" type="KDMYsoft.Model.Nhiber.S_Tree,KDMYsoft.Model" />
    </alias>
    <resultMaps>
    <resultMap id="SelectAllResult" class ="S_Tree">
    <result property="NodeID" column="NodeID" />
    <result property="Text" column="Text" />
    <result property="ParentID" column="ParentID" />
    <result property="ParentPath" column="ParentPath" />
    <result property="Location" column="Location" />
    <result property="OrderID" column="OrderID" />
    <result property="comment" column="comment" />
    <result property="Url" column="Url" />
    <result property="PermissionID" column="PermissionID" />
    <result property="ImageUrl" column="ImageUrl" />
    <result property="ModuleID" column="ModuleID" />
    <result property="KeShiDM" column="KeShiDM" />
    <result property="KeshiPublic" column="KeshiPublic" />
    </resultMap></resultMaps><statements>
    <select id="GetMaxID" resultClass="int">select max(ID) from S_Tree</select>
    <select id="Exists" resultClass="int" parameterclass="int">select count(1) from  S_Tree where ID = #value#</select>
    <insert id="InsertS_Tree" parameterclass="S_Tree">insert into S_Tree(NodeID,Text,ParentID,ParentPath,Location,OrderID,comment,Url,PermissionID,ImageUrl,ModuleID,KeShiDM,KeshiPublic) values (#NodeID#,#Text#,#ParentID#,#ParentPath#,#Location#,#OrderID#,#comment#,#Url#,#PermissionID#,#ImageUrl#,#ModuleID#,#KeShiDM#,#KeshiPublic#)</insert>
    <delete id="DeleteS_Tree" parameterclass="int">delete from  S_Tree where ID = #value#</delete>
    <select id="SelectAllS_Tree" resultMap="SelectAllResult">select * from  S_Tree</select>
    <select id="SelectByID" resultMap="SelectAllResult" resultClass="S_Tree" parameterclass="int">select * from S_Tree where ID = #value#</select>
    </statements>
    </sqlMap>
