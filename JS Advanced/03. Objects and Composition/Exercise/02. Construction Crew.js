function constructionCrew(worker) {
    if (worker.dizziness) {
        const amountNeeded = worker.weight * worker.experience * 0.1;
        worker.levelOfHydrated += amountNeeded;
        worker.dizziness = false;
    }

    return worker;
}

console.log(constructionCrew({
    weight: 80,
    experience: 1,
    levelOfHydrated: 0,
    dizziness: true
}));

console.log(constructionCrew({
    weight: 120,
    experience: 20,
    levelOfHydrated: 200,
    dizziness: true
}));

console.log(constructionCrew({
    weight: 95,
    experience: 3,
    levelOfHydrated: 0,
    dizziness: false
}));