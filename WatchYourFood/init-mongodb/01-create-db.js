/*

// Create user
dbAdmin = db.getSiblingDB("admin");
dbAdmin.createUser({
    user: "admin",
    pwd: "admin",
    roles: [{ role: "userAdminAnyDatabase", db: "admin" }],
    mechanisms: ["SCRAM-SHA-1"],
});

// Authenticate user
dbAdmin.auth({
    user: "watchyourfood",
    pwd: "watchyourfood",
    mechanisms: ["SCRAM-SHA-1"],
    digestPassword: true,
});

 */