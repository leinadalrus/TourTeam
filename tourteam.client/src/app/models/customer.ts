interface ICustomer {
  id: number
  nickname: string
}

class Permittor {
  owner: boolean = false // NOTE(Visitor): Visitor is the default rendering perspective.

  public getOwner(): boolean {
    return this.owner
  }
}

export class Customer {
  public endUsers: ICustomer[] = []

  public userPermission: Permittor = new Permittor

  public isAdmitted(): boolean {
    return true
  }
}
